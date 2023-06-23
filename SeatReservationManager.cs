// Link to the question: https://leetcode.com/problems/seat-reservation-manager/description/

public class SeatManager {
    int[] seats;
    int smallest = 0;
    
    public SeatManager(int n) {
        seats = new int[n];
        while (n > 0) {
            seats[n-1] = n--;
        }
    }
    
    public int Reserve() {
        int reserveSeat = seats[smallest];
        seats[smallest] = 0; 

        // find the next smallest seat
        for (int i = smallest; i < seats.Length; i++){
            if (seats[i] == 0) continue;
            smallest = i;
            break;
        }
        return reserveSeat;
    }
    
    public void Unreserve(int seatNumber) {
        seats[seatNumber-1] = seatNumber;

        // find if any prior smaller seat available
        for (int i = 0; i < seatNumber-1; i++) {
            if (seats[i] != 0) return;
        }
        smallest = seatNumber - 1;
    }
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */