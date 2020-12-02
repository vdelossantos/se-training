import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-voucher',
  templateUrl: './voucher.component.html',
  styleUrls: ['./voucher.component.scss']
})
export class VoucherComponent implements OnInit {
  @Input() voucherId: string;
  @Input() voucher: string;

  constructor(private router: ActivatedRoute) {
    this.voucher = '';
    this.voucherId = '';
  }

  ngOnInit(): void {
  }
}
