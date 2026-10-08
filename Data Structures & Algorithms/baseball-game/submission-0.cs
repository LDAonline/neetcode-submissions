public class Solution {
    public int CalPoints(string[] operations) {
        var numbers = new List<int>();
        var runningTotal = 0;
        foreach(string operation in operations)
        {
            if(int.TryParse(operation, out var operationNumber)){
                numbers.Add(operationNumber);
                runningTotal += operationNumber;
            }
            switch (operation){
                case "C":
                    var numberToRemove = numbers[numbers.Count - 1]; 
                    numbers.RemoveAt(numbers.Count - 1);
                    runningTotal -= numberToRemove;
                    break;

                case "D":
                    var result = (2 * numbers[numbers.Count - 1]);
                    numbers.Add(result);
                    runningTotal += result;
                    break;
                case "+":
                    var mostRecentNumber = numbers[numbers.Count - 1];
                    var secondMostRecentNumber = numbers[numbers.Count - 2];
                    var total = mostRecentNumber + secondMostRecentNumber;
                    numbers.Add(total);
                    runningTotal += total;
                    break;
                default:
                    break;

            }
                
        
        }
        return runningTotal;
    }
}