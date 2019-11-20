import { Component, OnInit } from '@angular/core';

export interface IdSAP {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-presupuesto',
  templateUrl: './presupuesto.component.html',
  styleUrls: ['./presupuesto.component.css']
})

export class PresupuestoComponent implements OnInit {

  idsaps: IdSAP[] = [
    { value: '0', viewValue: '' },
    { value: '1', viewValue: 'Id SAP 1' },
    { value: '2', viewValue: 'Id SAP 2' },
    { value: '3', viewValue: 'Id SAP 3' },
    { value: '4', viewValue: 'Id SAP 4' },
    { value: '5', viewValue: 'Id SAP 5' },
    { value: '6', viewValue: 'Id SAP 6' },
    { value: '7', viewValue: 'Id SAP 7' },
    { value: '8', viewValue: 'Id SAP 8' },
    { value: '9', viewValue: 'Id SAP 9' },
    { value: '10', viewValue: 'Id SAP 10' },
  ];

  fechaIni = '';
  fechaFin = '';

  TipoProyecto: string[] = ['', 'SW', 'HW'];
  SubTipo: string[] = ['', 'Central', 'Distribuido', 'Seguridad'];


  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  dataSource = ELEMENT_DATA;
  constructor() { }

  ngOnInit() {
  }

}


const ELEMENT_DATA = [
  { position: 1, name: 'Curso 1', weight: 'SI/NO', symbol: 'link a formato' },
  { position: 2, name: 'Curso 2', weight: 'SI/NO', symbol: 'link a formato' },
  { position: 3, name: 'Curso 3', weight: 'SI/NO', symbol: 'link a formato' },
  { position: 4, name: 'Curso 4', weight: 'SI/NO', symbol: 'link a formato' },
  { position: 5, name: 'Curso 5', weight: 'SI/NO', symbol: 'link a formato' },
];
