class Person{
    constructor(name,age){
        this.name = name;
        this.age = age;
    }
    get age(){
        return this._age;
    }
    set age(x){
        if(x <= 0)
        {
            throw new Error("Age shold be more than 0!");
        }
        this._age = x;
    }
}

class Child extends Person{
    constructor(name,age){
        super(name,age);
        this.name=name;
        this.age = age;
    }
    get name(){
        return super.name;
    }
    set name(x){
        super.name = x;
    }
    get age(){
        return super.age;
    }
    set age(x){
        
        if(x > 15)
        {
            throw new Error("Age should be less than 15");
        }
        super.age =x;
    }

}