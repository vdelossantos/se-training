import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Order } from './../../_shared/models/order.model';

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

  createOrder(order: Order): any {
    const orderTest = {
      senderEmail: 'juvia@ft.com',
      senderName: 'Juvia Lockser',
      recipientEmail: 'gray@ft.com',
      recipientName: 'Gray Fullbuster',
      voucher: '500 Voucher',
      dedication: 'From Juvia with Love',
      orderDate: undefined
    };

    const url = this.baseUrl + '/create_order';

    return this.http.post(url, orderTest).toPromise().then((data: any) => { console.log(data); });
  }
}
