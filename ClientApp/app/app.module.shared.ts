import { HttpModule } from '@angular/http';
import { BrowserModule } from '@angular/platform-browser';
import { TrackService } from './Services/track.service';
import { TrackComponent } from './components/track/track.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { EmployeeFormComponent } from './components/employee-form/employee-form.component';

import { ReactiveFormsModule, FormsModule } from "@angular/forms";

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        EmployeeFormComponent,
        TrackComponent
    ],
    imports: [
        BrowserModule,
        ReactiveFormsModule, FormsModule,
        HttpModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'employee/new', component: EmployeeFormComponent },
            { path: 'test', component: TrackComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: '**', redirectTo: 'home' }
        ])
        
    ]
};
