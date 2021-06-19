// app.compoment.spec.ts
import { TestBed, async } from '@angular/core/testing'; // 1
import { FetchMoviesComponent } from './movie-list.component';
 
describe('FetchMoviesComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        FetchMoviesComponent,
      ],
    }).compileComponents();
  }));
 
  it('should create the app', () => {
    const fixture = TestBed.createComponent(FetchMoviesComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  });
 
  it('should render title in a h1 tag', () => {
    const fixture = TestBed.createComponent(FetchMoviesComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('Movies List');
  });
});