import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { GetAllSuppliersComponent } from './components/get-all-suppliers/get-all-suppliers.component';
import { InsertUpdateSuppliersComponent } from './components/insert-update-suppliers/insert-update-suppliers.component';
import { GetSupplierComponent } from './components/get-supplier/get-supplier.component';

const routes: Routes = [
  
  {path:'', redirectTo:'listSuppliers',pathMatch:'full'},
  {path:'listSuppliers', component: GetAllSuppliersComponent},
  {path:'InsertSuppliers', component: InsertUpdateSuppliersComponent},
  {path:'UpdateSuppliers/:id', component: InsertUpdateSuppliersComponent},
  {path:'getSupplier/:id', component: GetSupplierComponent},
  {path:'**', redirectTo:'listSuppliers',pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
