import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
  //fullname: string = "Hello Angular";
  numbers: number[] = [19, 29, 39, 49, 59];
  uniform: number[] = [10, 20, 30, 40, 50];
  titlee:any="Top movies";
  movies: Movie[]=[
        { title: 'Avengers', director: 'Stanley', cast: 'TonyStark', releasedate: 'dec23 2019' },
        { title: 'KGF', director: 'Prasanth Neil', cast: 'Yash,Srinidhi', releasedate: 'Dec12,2019' },
        { title: 'Bahubali', director: 'Rajamouli', cast: 'Prabhas,Anuskha,Thamanna', releasedate: 'June 206' },
    ];
    items: item[] = [
      { name: 'Kavya', age: 21 },
      { name: 'Navya', age: 22 },
      { name: 'Bhavya', age: 23 },
  ];
  selectedValue: string = 'Kavya';
  values: value[] = [{name: 'One', val: 1}, {name: 'Two', val: 2}, {name: 'Three', val: 3}];  
  selectedValue1: string= 'One';
  constructor() { }

  ngOnInit(): void {
  }

}
class Movie {
      title: string;
      director: string;
      cast: string;
      releasedate: string;
  }  
    class item{
      name:string;
      age:number;
    }
    class value {  
      name: string;  
      val: number;  
  }  