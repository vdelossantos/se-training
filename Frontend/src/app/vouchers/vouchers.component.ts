import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationStart, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-vouchers',
  templateUrl: './vouchers.component.html',
  styleUrls: ['./vouchers.component.scss']
})
export class VouchersComponent implements OnInit {

  constructor(private toastrService: ToastrService, private activatedRoute: ActivatedRoute, private router: Router) {
    this.toastrService.toastrConfig.preventDuplicates = true;
  }

  ngOnInit(): void {
    if (this.activatedRoute.snapshot.params.submitStatus === 'ok') {
      this.toastrService.success('Successful!');
    }
  }
}
