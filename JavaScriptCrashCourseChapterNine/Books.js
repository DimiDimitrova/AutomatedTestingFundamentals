class Book{
    constructor(title,author,price){
        this.title = title;
        this.author = author;
        this.price = price;
    }
    get title(){
        return this._title;
    }
    set title(x){
        if(x.length < 3)
        {
            throw new Error("Title not valid!");
        }
        this._title = x;
    }

    get author(){
        return this._author;
    }
    set author(x){
        function checkFirstLetterNumber(_string)
        {
         return /^\d/.test( _string);
        }
        let temp = x.toString();
        const arr = temp.split(' ');
        let secondName = arr[arr.length - 1];
        let c = checkFirstLetterNumber(secondName);
             
        if (c == true)
        {
            throw new Error("Author not valid");
        }
        if(x.length < 3)
        {
            throw new Error("Title not valid!");
        }
        this._author = x;
    }

    get price(){
        return this._price;
    }
    set price(x){
        if(x <= 0)
        {
            throw new Error("Price not valid!");
        }
        this._price = x;
    }
   
}
class GoldenEditonBook extends Book{
    constructor(title,author,price){
        super(title,author,price);
        this.title = title;
        this.author = author;
        this.price = price;
    }
    get title(){
        return super.title;
    }
    set title(x){
        super.title = x;
    }

    get author(){
        return super.author;
    }
    set author(x){
        super.author = x;
    }
    get price(){
        return super.price;
    }
    set price(x){
        
        let temp = x * 0.3 + x;
        super.price = temp;
    }
}