/// <reference path="../../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { OpsManualesComponent } from './ops-manuales.component';

let component: OpsManualesComponent;
let fixture: ComponentFixture<OpsManualesComponent>;

describe('ops-manuales component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ OpsManualesComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(OpsManualesComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});