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

  constructor(private orderService: OrderService) {
    this.orders = [];
    this.emailSearchText = '';
  }

  ngOnInit(): void {
    this.orders = [];
  }

  getOrders(): void {
    this.orderService.getOrdersBySender(this.emailSearchText).subscribe((response: any) => {
      this.orders = response.data;
    });
  }
}
