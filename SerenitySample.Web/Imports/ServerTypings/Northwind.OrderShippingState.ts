namespace SerenitySample.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'SerenitySample.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
