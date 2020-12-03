import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { OrderService } from './../core/services/order.service';
import { finalize } from 'rxjs/operators';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss']
})
export class CheckoutComponent implements OnInit {
  formValid: boolean;
  postError: boolean;
  checkoutForm: any;
  senderEmail: string;
  senderName: string;
  recipientEmail: string;
  recipientName: string;
  voucherName: string;
  dedication: string;

  constructor(private router: Router, private route: ActivatedRoute, private orderService: OrderService, private formBuilder: FormBuilder) {
    this.formValid = false;
    this.postError = true;

    this.senderEmail = '';
    this.senderName = '';
    this.recipientEmail = '';
    this.recipientName = '';
    this.voucherName = '';
    this.dedication = '';
  }

  ngOnInit(): void {
    this.formValid = true;

    this.senderEmail = '';
    this.senderName = '';
    this.recipientEmail = '';
    this.recipientName = '';
    this.voucherName = this.route.snapshot.params.voucherName + ' Voucher';
    this.dedication = '';
  }


  createOrder(isFormValid: any): void {
    if (isFormValid) {
      this.orderService.createOrder({
        senderEmail: this.senderEmail,
        senderName: this.senderName,
        recipientEmail: this.recipientEmail,
        recipientName: this.recipientName,
        voucher: this.voucherName,
        dedication: this.dedication
      }).then((response: any) => {
        if (response.errorCode.length === 0) {
          this.router.navigateByUrl('vouchers/ok', { state: { data: response } });
        }
      });

      /*subscribe((response: any) => {
        this.postError = response.errorCode !== '';
        console.log(this.postError);
      });

      console.log(this.postError);

      if (!this.postError) {
        this.router.navigate([''], { state: { postError: this.postError } });
      }
      */
    }
  }
}
