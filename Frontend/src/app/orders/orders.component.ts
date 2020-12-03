import { finalize } from 'rxjs/operators';
import { Component, OnInit } from '@angular/core';

import { OrderService } from './../core/services/index';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss']
})
export class OrdersComponent implements OnInit {
  emailSearchText: string;
  orders: any;
  finishedLoading = true;

  constructor(private orderService: OrderService) {
    this.orders = [];
    this.emailSearchText = '';
  }

  ngOnInit(): void {
    this.orders = [];
  }

  getOrders(): any {
    this.finishedLoading = false;

    this.orderService.getOrdersBySender(this.emailSearchText).pipe(
      finalize(() => {
        setTimeout(() => {
          this.finishedLoading = true;
        });
      })
    ).subscribe((response: any) => {
      this.orders = response.data;
    });
  }
}
