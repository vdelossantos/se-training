import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-voucher',
  templateUrl: './voucher.component.html',
  styleUrls: ['./voucher.component.scss']
})
export class VoucherComponent implements OnInit {
  @Input() voucherId: string;
  @Input() voucher: string;

  constructor(private router: ActivatedRoute, private toastr: ToastrService) {
    this.voucher = '';
    this.voucherId = '';
  }

  ngOnInit(): void {
  }
}
