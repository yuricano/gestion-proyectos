/// <reference path="../../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { PresupuestoComponent } from './presupuesto.component';

let component: PresupuestoComponent;
let fixture: ComponentFixture<PresupuestoComponent>;

describe('presupuesto component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ PresupuestoComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(PresupuestoComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});