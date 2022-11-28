const minSize = 1;
const maxSize = 30;
for(let i = minSize; i <= maxSize; i++)
{
 console.log(i);
}
const three = 3;
const seven = 7;
for(let i = minSize; i <= maxSize; i++)
{
  if(i % three === 1 && i % 7 === 1)
  {
    console.log(i);
  }
}
const arrLength = 20;
const numbers = [];
for (let index = 0; index < arrLength; index++) {
   numbers.push(index * 5);
    
}
numbers.forEach(n => console.log(n))