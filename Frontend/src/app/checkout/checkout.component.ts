import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { OrderService } from './../core/services/order.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss']
})
export class CheckoutComponent implements OnInit {
  voucherName: string;

  constructor(private route: ActivatedRoute, private orderService: OrderService) {
    this.voucherName = '';
  }

  ngOnInit(): void {
    this.voucherName = this.route.snapshot.params.voucherName + ' Voucher';
  }


  createOrder(): void {
    const order = {
      senderEmail: 'juvia@ft.com',
      senderName: 'Juvia Lockser',
      recipientEmail: 'gray@ft.com',
      recipientName: 'Gray Fullbuster',
      voucher: this.voucherName,
      dedication: 'From Juvia with Love',
      orderDate: new Date()
    };

    this.orderService.createOrder(order);
  }
}
