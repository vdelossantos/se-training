import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  readonly baseUrl = 'https://localhost:5001/api';

  constructor(private http: HttpClient) { }

  getOrders(): Observable<any> {
    const url = this.baseUrl + '/orders';
    const response = this.http.get(url);

    return response;
  }

  getOrdersBySender(senderEmail: string): Observable<any> {
    const url = this.baseUrl + '/orders/' + senderEmail;
    const response = this.http.get(url);

    return response;
  }

  createOrder(order: any): any {
    const url = this.baseUrl + '/create_order';

    return this.http.post(url, order).toPromise().then((data: any) => { console.log(data); });
  }
}
