/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { EstimacionComponent } from './estimacion.component';

let component: EstimacionComponent;
let fixture: ComponentFixture<EstimacionComponent>;

describe('estimacion component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ EstimacionComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(EstimacionComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});