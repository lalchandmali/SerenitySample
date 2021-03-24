namespace SerenitySample.Northwind {
    export enum Gender {
        Male = 1,
        Female = 2
    }
    Serenity.Decorators.registerEnumType(Gender, 'SerenitySample.Northwind.Gender', 'SerenitySample.Northwind.Entities.Gender');
}
