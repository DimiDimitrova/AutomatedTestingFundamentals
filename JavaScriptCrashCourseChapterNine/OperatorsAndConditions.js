let inputNumber = prompt('Enter a number: ');

if(Number(inputNumber) % 2 == 0 )
{
     alert(`Number ${inputNumber} is even.`);
}
else{ 
    alert(`Number ${inputNumber} is odd.`);
}

let width = prompt("Enter rectangle's width: ");
let height = prompt("Enter rectangle's height: ");
let rectangleArea = width * height;

console.log(rectangleArea.toPrecision(4));

let a = prompt("Enter trapezoid's side a: ");
let b = prompt("Enter trapezoid's side b: ");
let h = prompt("Enter trapezoid's h: ");
let trapezoidArea = ((a + b)/2) *h;

console.log(Number(trapezoidArea));

let firstNumber = prompt("Enter first number: ");
let secondNumber = prompt("Enter second number: ");
firstNumber=Number(firstNumber);
secondNumber=Number(secondNumber);
if(Number(firstNumber) > Number(secondNumber))
{
    firstNumber = firstNumber + secondNumber;
    secondNumber = firstNumber - secondNumber; 
    firstNumber = firstNumber - secondNumber;
}

const number = parseInt(prompt("Enter a positive number: "));
let isPrime = true;

if (number === 1) {
    console.log(`${number} is not prime.`);
}
else if (number > 1) {
    for (let i = 2; i < number; i++) {
        if (number % i == 0) {
            isPrime = false;
            break;
        }
    }


    
    if (isPrime) {
        console.log(`${number} is a prime number`);
    } else {
        console.log(`${number} is a not prime number`);
    }
}
