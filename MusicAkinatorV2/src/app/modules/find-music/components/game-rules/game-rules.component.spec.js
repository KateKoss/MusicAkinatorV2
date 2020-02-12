/* tslint:disable:no-unused-variable */
import { async, TestBed } from '@angular/core/testing';
import { GameRulesComponent } from './game-rules.component';
describe('GameRulesComponent', function () {
    var component;
    var fixture;
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [GameRulesComponent]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = TestBed.createComponent(GameRulesComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', function () {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=game-rules.component.spec.js.map