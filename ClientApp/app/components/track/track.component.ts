import { TrackService } from './../../Services/track.service';
import { TrackModel } from './../../Model/track-model';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { Http } from "@angular/http";
import { Router } from "@angular/router";

@Component({
    selector: 'app-track',
    templateUrl: './track.component.html',
    styleUrls: ['./track.component.css'],
    providers: [TrackService]
})

export class TrackComponent implements OnInit {

    track = new FormGroup({
        'trackingNumber': new FormControl('', Validators.required)
    })
    TrackingDetails: TrackModel;

    constructor(private _service: TrackService, private _router: Router) { }
    ngOnInit() { }

    get trackingNumber() {
        return this.track.get('trackingNumber');
    }
    trackPackage() {
        //validation for empty field
        if (this.trackingNumber.value == "") {
            this.track.setErrors({
                emptyField: true
            })
            return;
        }

        //call backend 
        this._service.getTrackingDetails(this.trackingNumber.value)
            .subscribe(response => {
                this.TrackingDetails = response.json();
            })
        if (this.TrackingDetails.statusCode === null) {
            this.track.setErrors({
                statusCode: true
            })
            return;
        }
        this._router.navigate(['/trackDetails'])

    }

}
