import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';

import { CarrosService } from './carros/carros.service';
import { CarrosComponent } from './components/carros/carros.component'

@NgModule({
  declarations: [
    AppComponent,
    CarrosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    ModalModule
  ],
  providers: [HttpClientModule, CarrosService],
  bootstrap: [AppComponent]
})
export class AppModule { }
