/// <reference path="../../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { ConsumoComponent } from './consumo.component';

let component: ConsumoComponent;
let fixture: ComponentFixture<ConsumoComponent>;

describe('consumo component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ ConsumoComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(ConsumoComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});