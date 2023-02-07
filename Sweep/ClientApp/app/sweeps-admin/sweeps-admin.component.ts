import { Component, OnInit } from '@angular/core';
import { SweepService } from '../sweep.service';

@Component({
  selector: 'app-sweeps-admin',
  templateUrl: './sweeps-admin.component.html',
  styleUrls: ['./sweeps-admin.component.css']
})
export class SweepsAdminComponent implements OnInit {

    public sweeps = [];

  constructor(private service: SweepService) { }

    ngOnInit() {
        this.getSweeps();
  }

    getSweeps(): void {
        this.service.getAdminSweeps()
            .subscribe(sweeps => this.sweeps = sweeps);
    }

}
