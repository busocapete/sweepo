import { Component, OnInit } from '@angular/core';
import { SweepService } from '../sweep.service';
import { Sweep } from '../Sweep';
import { UserAuth } from '../UserAuth';
import { AuthService } from '../auth.service';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'sweeps-list',
  templateUrl: './sweeps.component.html',
  styleUrls: ['./sweeps.component.css']
})

export class SweepsComponent implements OnInit {
    private userAuth: UserAuth;
    public sweeps = [];


    constructor(private service: SweepService,
    private userService: AuthService) { }



    ngOnInit(): void {
        this.userService.getUserAuthDetails().subscribe(data => {
            this.userService.userAuth = data;
            this.userAuth = this.userService.userAuth;
        });

        this.getSweeps();
    }

    isUserOwner(sweep: Sweep) {
        return this.userService.userAuth.sweepIds.some(s => s == sweep.id);
    }


    getSweeps(): void {
        this.service.getSweeps()
            .subscribe(sweeps => this.sweeps = sweeps);
    }


    joinSweep(sweep: Sweep): void {
        this.service.joinSweep(sweep.id).subscribe(data => {
            sweep.userIsMember = true;
            sweep.approved = data.approved
        });
    }


    createSweep(): void {
        this.createSweepForm.patchValue({

        })

        this.service.createSweep(this.createSweepForm.value).subscribe(data => {
            this.sweeps.unshift(data);
            this.createSweepForm.reset();
            $('#createSweepModal').modal('toggle');
        });
    }


    createSweepForm = new FormGroup({
        name: new FormControl(''),
        public: new FormControl(false) 
    })
}
