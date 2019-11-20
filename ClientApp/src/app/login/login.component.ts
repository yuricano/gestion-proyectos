import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

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

  acceso() {
    this.showSuccess('Acceso correcto');
  }

  ngOnInit() {
  }

}
