import { Http } from '@angular/http';
import { Injectable } from '@angular/core';

@Injectable()
export class TrackService {
  private api="/Track/GetStatus/";
  constructor(private _http:Http) { }
getTrackingDetails(id:string){
  return this._http.get(this.api+id);
}
}
