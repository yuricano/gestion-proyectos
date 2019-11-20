/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { AprobacionComponent } from './aprobacion.component';

let component: AprobacionComponent;
let fixture: ComponentFixture<AprobacionComponent>;

describe('aprobacion component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ AprobacionComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(AprobacionComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});