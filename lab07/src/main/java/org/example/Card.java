package org.example;

public class Card {
    public String FIO;
    public float balance;
    public String status;

    public Card(String FIO, float balance, String status) {
        this.FIO = FIO;
        this.balance = balance;
        this.status = status;
    }
    public void block(){
        this.status = "blocked";
    }
    public void unblock(){
        this.status = "unblocked";
    }

    public void withdrawMoney(float sum){
        this.balance -= sum;
    }

    public float getBalance(){
        return balance;
    }

    public String getStatement(float sum){
        return "FIO:" +  FIO + "#BALANCE:" + balance;
    }

    public void depositMoney(float sum){
        this.balance += sum;
    }

    public void pay(float sum){
        if(status.equals("unblocked"))
            if(this.balance >= sum)
                this.balance -= sum;
    }
}
