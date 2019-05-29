public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        List<PointDistance> distances = new List<PointDistance>();
        calculateDistances(points, distances);

        distances.Sort();

        int[][] result = new int[K][];

        for (int i = 0; i < K; i++)
        {
            result[i] = new int[2] { 0, 0 };
            result[i][0] = distances[i].coordinates[0];
            result[i][1] = distances[i].coordinates[1];
        }
        return result;
    }
    
    private double getDistanceFromOrigin(int x1, int y1){
        return Math.Sqrt(Math.Pow(x1,2) + Math.Pow(y1,2));
    }
    
    private void calculateDistances(int[][] points, IList<PointDistance> distances) {
        for(int i = 0; i < points.Length; i++){
            distances.Add(new PointDistance(points[i], getDistanceFromOrigin(points[i][0], points[i][1])));
        }
    }
    
    class PointDistance : IComparable<PointDistance> {
        public double distance;
        public int[] coordinates;
        
        public PointDistance(int[] c, double d){
            coordinates = c;
            distance = d;
        }
        
        public int CompareTo(PointDistance other) {
            return distance.CompareTo(other.distance);
        }
    }
}
