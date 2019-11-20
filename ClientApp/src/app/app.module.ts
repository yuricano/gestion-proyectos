import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { LayoutModule } from '@angular/cdk/layout';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule, MatListModule, MatNativeDateModule, MatCardModule, ErrorStateMatcher } from '@angular/material';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';
import { MatBadgeModule } from '@angular/material/badge';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatTableModule } from '@angular/material/table';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { ToastrModule } from 'ngx-toastr';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SidenavComponent } from './sidenav/sidenav.component';
import { LoginComponent } from './login/login.component';
import { AppComponent } from './app.component';
import { GestionComponent } from './gestion/gestion.component';
import { PresupuestoComponent } from './gestion/presupuesto/presupuesto.component';
import { ConsumoComponent } from './gestion/consumo/consumo.component';
import { OpsManualesComponent } from './gestion/ops-manuales/ops-manuales.component';
import { EstimacionComponent } from './estimacion/estimacion.component';
import { AprobacionComponent } from './aprobacion/aprobacion.component';
import { ReportesComponent } from './reportes/reportes.component';

@NgModule({
  declarations: [
    AppComponent,
    SidenavComponent,
    LoginComponent,
    GestionComponent,
    PresupuestoComponent,
    ConsumoComponent,
    OpsManualesComponent,
    EstimacionComponent,
    AprobacionComponent,
    ReportesComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'gestion' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    MatTableModule,
    MatSnackBarModule,
    MatCheckboxModule,
    MatInputModule,
    MatFormFieldModule,
    MatBadgeModule,
    MatMenuModule,
    LayoutModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatCardModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: LoginComponent },
      { path: 'gestion', component: GestionComponent },
      { path: 'presupuesto', component: PresupuestoComponent },
      { path: 'conusmo', component: ConsumoComponent },
      { path: 'ops-manuales', component: OpsManualesComponent },
      { path: 'estimacion', component: EstimacionComponent },
      { path: 'aprobacion', component: AprobacionComponent },
      { path: 'reportes', component: ReportesComponent },
      { path: '**', redirectTo: '' }
    ]),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
