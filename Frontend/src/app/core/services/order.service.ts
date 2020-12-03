import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { finalize } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  readonly baseUrl = 'https://localhost:5001/api';
  finishedLoading = false;

  constructor(private http: HttpClient) { }

  getOrders(): Observable<any> {
    const url = this.baseUrl + '/orders';
    const response = this.http.get(url);

    return response;
  }

  getOrdersBySender(senderEmail: string): any {
    const url = this.baseUrl + '/orders/' + senderEmail;
    return this.http.get(url);
  }

  async createOrder(order: any): Promise<any> {
    const url = this.baseUrl + '/create_order';

    // return this.http.post(url, order).toPromise().then((data: any) => { console.log(data); });
    return await this.http.post(url, order).toPromise();
  }
}
