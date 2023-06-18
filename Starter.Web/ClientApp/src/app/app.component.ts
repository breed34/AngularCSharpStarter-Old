import { Component } from '@angular/core';
import { PingService } from './services';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  constructor(private pingService: PingService) { }

  public ping$: Observable<string> = this.pingService.ping();
}
