const person={firstName:'john',lastName:'doe'};
const {firstName,lastName} =person;
console.log(firstName);
console.log(lastName);


const{firstName:first,lastName:last}=person;
console.log(first);
console.log(last);


const{age=30}=person;
console.log(age);


const user={
    fname:'alice',
    address:{
        street:'123 main st',
        city:'wonderland'
    }
};
const{fname,address:{city}}=user;
console.log(fname);
console.log(city);


