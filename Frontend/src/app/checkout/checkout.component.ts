import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { OrderService } from './../core/services/order.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss']
})
export class CheckoutComponent implements OnInit {
  senderEmail: string;
  senderName: string;
  recipientEmail: string;
  recipientName: string;
  voucherName: string;
  dedication: string;

  constructor(private router: Router, private route: ActivatedRoute, private orderService: OrderService) {
    this.senderEmail = '';
    this.senderName = '';
    this.recipientEmail = '';
    this.recipientName = '';
    this.voucherName = '';
    this.dedication = '';
  }

  ngOnInit(): void {
    this.senderEmail = '';
    this.senderName = '';
    this.recipientEmail = '';
    this.recipientName = '';
    this.voucherName = this.route.snapshot.params.voucherName + ' Voucher';
    this.dedication = '';
  }


  createOrder(): void {
    this.orderService.createOrder({
      senderEmail: this.senderEmail,
      senderName: this.senderName,
      recipientEmail: this.recipientEmail,
      recipientName: this.recipientName,
      voucher: this.voucherName,
      dedication: this.dedication
    });

    this.router.navigate(['']);
  }
}
