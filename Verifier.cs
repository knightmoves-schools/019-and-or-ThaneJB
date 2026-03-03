namespace knightmoves;
public class Verifier
{
    // Add your code here
    public string Taxable(string state, bool taxExempt){
        if (state == "IA" && taxExempt == false){
            return "is taxable";
        }
        else if (state == "IA" && taxExempt == true){
            return "";
        }
        else (state == "FL" && taxExempt == false){
            return "";
        }
    }
    
    public string IsVehicle(bool hasWheels, bool canFly, bool canSwim){
        if (hasWheels == true || canFly == true || canSwim == true){
            return "is vehicle";
        }
        else (hasWheels == false && canFly == false && canSwim == false){
            return "";
        }
    }
}
