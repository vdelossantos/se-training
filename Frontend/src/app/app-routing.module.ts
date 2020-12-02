import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CheckoutComponent } from './checkout/checkout.component';
import { OrdersComponent } from './orders/orders.component';
import { VouchersComponent } from './vouchers/vouchers.component';

const routes: Routes = [
  { path: '', component: VouchersComponent },
  { path: 'checkout/:voucherName', component: CheckoutComponent },
  { path: 'orders', component: OrdersComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
