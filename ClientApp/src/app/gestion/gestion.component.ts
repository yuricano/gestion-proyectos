import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-gestion',
  templateUrl: './gestion.component.html',
  styleUrls: ['./gestion.component.css']
})
export class GestionComponent implements OnInit {

  constructor(private toastr: ToastrService) { }

  showSuccess(mensaje: string) {
    this.toastr.success(mensaje, 'OK!',
      { timeOut: 2000 });
  }
  showError(mensaje: string) {
    this.toastr.error(mensaje, 'Error!', {
      timeOut: 3000
    });
  }

  ngOnInit() {
  }
}
