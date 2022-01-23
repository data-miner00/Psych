namespace Psych.Core.Models

open System

type TransactionType =
    | Undetermined = 0
    | Deposit = 1
    | Withdraw = 2
    | Transfer = 3
    | Payment = 4
    | Loan = 5

type TransactionStatus =
    | Invalid = 0
    | Success = 1
    | Failure = 2
    | Pending = 3
    | Rejected = 4

type Transaction(type': TransactionType, amount: float, balance: float, targetAccountNumber: string,
                 reference: string, additionalReference: string, status: TransactionStatus) =
    
    member val Id = id() with get
    member val Date = DateTime() with get
    member val Type' = type' with get
    member val Amount = amount with get
    member val Balance = balance with get
    member val TargetAccountNumber = targetAccountNumber with get
    member val Reference = reference with get
    member val AdditionalReference = additionalReference with get
    member val Status = status with get, set

