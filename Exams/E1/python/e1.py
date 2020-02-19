class Student:
    Gr = []
    We = []
    def init(s,G,W):
        for i in range(len(G)):
            s.Grades.append(G[i])
            s.Weights.append(W[i])

    def GetAvg(s):
        sum = 0
        w = 0
        for i in range(len(s.Grades)):
        
            sum+=s.Grades[i]*s.Weights[i]
            w+=s.Weights[i]
        
        return sum/w

if name == "main":
    Grades = [15,18,17,20,16,14]
    Weights = [2,3,3,1,2,1]
    s = Student(Grades,Weights)
    print(s.GetAvg())