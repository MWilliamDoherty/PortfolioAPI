import { Component, OnInit } from '@angular/core';
import { RecipeService, Recipe, Step } from '../recipe.service';
import { HttpClient, HttpParams } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import "@angular/compiler";

let header = new HttpHeaders();
header.set('Access-Control-Allow-Origin', '*');

@Component({
  selector: 'app-open-page',
  templateUrl: './open-page.component.html',
  styleUrls: ['./open-page.component.css'],
  providers: [ RecipeService ]
})
export class OpenPageComponent implements OnInit {

  configUrl = 'https://localhost:44396';
  
  show:boolean | undefined;
  recipes:Recipe[];
  recipe:Recipe;
  //selectedRecipe

  constructor(
    public service: RecipeService,
    public http: HttpClient
    ) { 
      this.recipes = new Array<Recipe>();
      this.recipe = new Recipe;
    }
    

  ngOnInit() {
    this.show = true;
    this.recipes = new Array<Recipe>();
    this.recipe = new Recipe;
    this.recipe.Steps = new Array<Step>();
    this.getRecipeNames();
  }

  getRecipeNames(){
    //this.recipes.push(this.recipe);
    this.http.get<Array<Recipe>>(this.configUrl + '/api/Recipe').subscribe(data => {
      //this.recipe = data.
      this.recipes = this.recipes.concat(data);
    });
  }

  checkValue(id:number){
    this.show = true;
    this.http.get<Recipe>(this.configUrl + '/api/Recipe/' + id).subscribe(data => {
      this.recipe = data;
    })
  }

  getRecipe(){
    

  }

}
