import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Isupplier } from 'src/app/interfaces/isupplier';
import { SSuppliersService } from 'src/app/services/ssuppliers.service';

@Component({
  selector: 'app-get-supplier',
  templateUrl: './get-supplier.component.html',
  styleUrls: ['./get-supplier.component.css']
})
export class GetSupplierComponent implements OnInit {

  id: number;
  supplier!: Isupplier;
  
  constructor(private _serviceSupplier: SSuppliersService,
    private ruta: ActivatedRoute) { 
      this.id = parseInt(this.ruta.snapshot.paramMap.get('id')!);
    }

  ngOnInit(): void {
    this.getSupplier();
  }

  getSupplier() {
    this._serviceSupplier.getSupplier(this.id).subscribe({
      next: (proveedor) => {
        this.supplier = proveedor;
        console.log(proveedor);
      },
      error: (e) => alert('Error al cargar, compruebe la conexión'),
      complete: () => console.log('completado ok')
    })
  }

}
