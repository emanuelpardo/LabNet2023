import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Isupplier } from 'src/app/interfaces/isupplier';
import { SSuppliersService } from 'src/app/services/ssuppliers.service';



@Component({
  selector: 'app-insert-update-suppliers',
  templateUrl: './insert-update-suppliers.component.html',
  styleUrls: ['./insert-update-suppliers.component.css']
})

export class InsertUpdateSuppliersComponent implements OnInit {
  formSupplier: FormGroup
  mensaje: string;
  id:number;
  constructor(private fbuilder: FormBuilder,
     private _serviceSupplier: SSuppliersService,
     private router: Router,
     private ruta: ActivatedRoute ) {
   
   this.formSupplier = fbuilder.group({
  compania: ['', [Validators.required, Validators.maxLength(40)]],
  contacto: ['', Validators.maxLength(30)],
  ciudad: ['', Validators.maxLength(15)]
})

    this.mensaje = ''
    this.id = Number(this.ruta.snapshot.paramMap.get('id'));
    console.log(this.id);

  }

  ngOnInit(): void {
    if(this.id != 0){
      this.getSupplier(this.id)
    }
  }

  getSupplier(id:number){
    this._serviceSupplier.getSupplier(id).subscribe(data => {
      this.formSupplier.patchValue({        
        compania: data.NombreCompania,
        contacto: data.NombreContacto,
        ciudad: data.Ciudad
      });
    }) 
  }


  insertUpdateSuppliers() {
    const supplier: Isupplier = {
      NombreCompania: this.formSupplier.value.compania,
      NombreContacto: this.formSupplier.value.contacto,
      Ciudad: this.formSupplier.value.ciudad
    }
  
    
    this._serviceSupplier.insertUpdateSupplier(this.id,supplier).subscribe({
      next: (list) => {
        this.mensaje = list;
      },
      error: (e) => alert('Error al cargar, compruebe la conexión'),
      complete: () => {
        if (this.mensaje.length > 0) {
          alert(this.mensaje)
          this.router.navigate(['listSuppliers'])
        }
      }
    })
    
  }
}


