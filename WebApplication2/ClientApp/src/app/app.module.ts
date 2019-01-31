import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { DataTableModule } from "angular-6-datatable";

import { LOCALE_ID } from '@angular/core'; 
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ClientesComponent } from './clientes/clientes.component';
import { ClientesService } from './clientes/clientes.service';
import { ClientesFormComponent } from './clientes/clientes-form/clientes-form.component';
import { LogInterceptorService } from './services/log-interceptor.service';
import { MaquinasService } from './maquinas/maquinas.service';
import { MaquinasComponent } from './maquinas/maquinas.component';
import { ReparacionesComponent } from './reparaciones/reparaciones.component';
import { ReparacionesService } from './reparaciones/reparaciones.service';
import { ReparacionesFormComponent } from './reparaciones/reparaciones-form/reparaciones-form.component';
import { ProductosComponent } from './productos/productos.component';
import { ProveedoresComponent } from './proveedores/proveedores.component';
import { RepuestosComponent } from './repuestos/repuestos.component';
import { ProveedoresFormComponent } from './proveedores/proveedores-form/proveedores-form.component';
import { DatatablesProveedorComponent } from './proveedores/datatables-proveedor/datatables-proveedor.component';
import { DatatablesClientesComponent } from './clientes/datatables-clientes/datatables-clientes.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ClientesComponent,
    ClientesFormComponent,
    MaquinasComponent,
    ReparacionesComponent,
    ReparacionesFormComponent,
    ProductosComponent,
    ProveedoresComponent,
    RepuestosComponent,
    ProveedoresFormComponent,
    DatatablesProveedorComponent,
    DatatablesClientesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    DataTableModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'Clientes', component: ClientesComponent },
      { path: 'Clientes-agregar', component: ClientesFormComponent },
      { path: 'Clientes-editar/:id', component: ClientesFormComponent },
      { path: 'maquinas/:id', component: MaquinasComponent },
      { path: 'reparaciones/:id', component: ReparacionesComponent },
      { path: 'reparaciones-agregar/:id', component: ReparacionesFormComponent },
      { path: 'repuestos', component: RepuestosComponent },
      { path: 'proveedores', component: ProveedoresComponent },


    ])
  ],
  providers: [ClientesService, MaquinasService, ReparacionesService,
    {
     
      provide: HTTP_INTERCEPTORS,
      useClass: LogInterceptorService,
      multi: true
   
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
