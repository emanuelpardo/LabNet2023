import { Component, OnInit } from '@angular/core';
import { Isupplier } from 'src/app/interfaces/isupplier';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatTableDataSource } from '@angular/material/table';
import { SSuppliersService } from 'src/app/services/ssuppliers.service';

@Component({
  selector: 'app-get-all-suppliers',
  templateUrl: './get-all-suppliers.component.html',
  styleUrls: ['./get-all-suppliers.component.css']
})


export class GetAllSuppliersComponent implements OnInit {
  displayedColumns: string[] = ['nombreCompania', 'nombreContacto', 'ciudad', 'operacion'];
  dataSource = new MatTableDataSource<Isupplier>();
  mensaje: string;
  constructor(private _snackBar: MatSnackBar, private _serviceSupplier: SSuppliersService) { this.mensaje = '' }

  ngOnInit(): void {
    this.getAllSuppliers();
  }

  eliminarSupplier(id?: number) {
    this._serviceSupplier.deleteSupplier(id).subscribe({
      next: (list) => {
        this.mensaje = list;
      },
      error: (e) => alert('Error al cargar, compruebe la conexión'),
      complete: () => this.getAllSuppliers()

    })

    if (this.mensaje.length > 0) {
      this._snackBar.open(this.mensaje, '', {
        duration: 3000,
        verticalPosition: 'top'
      });
    }

  }



  getAllSuppliers() {
    this._serviceSupplier.getListSuppliers().subscribe({
      next: (list) => {
        this.dataSource.data = list;
      },
      error: (e) => alert('Error al cargar, compruebe la conexión'),
      complete: () => console.log('completado ok')
    })
  }



}


