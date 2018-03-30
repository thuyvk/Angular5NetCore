import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { SchoolService } from '../../services/school.service'

@Component({
    templateUrl: './categories.component.html'
})


export class CategoriesComponent {
    public cateList: Category[];

    constructor(public http: Http, private _router: Router, private _schoolService: SchoolService) {
        this.getCategories();
    }

    ngOnInit() {
        console.log('hello on init');
    }

    getCategories() {
        this._schoolService.getCategories()
            .subscribe(
            res => {
                this.cateList = res;
                console.log(res);
            },
            err => {
                console.error(err);
            }
            )
    }


}

interface Category {
    id: string;
    cateName: string
} 