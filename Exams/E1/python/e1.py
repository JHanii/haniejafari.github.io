class Student:
    Gr = []
    We = []
    def init(self,Gr,We):
        for i in range(len(Gr)):
            self.Gr.append(Gr[i])
            self.We.append(We[i])
    

    def Avg(self):
        sum = 0
        a = 0
        for i in range(len(st.Gr)):
        
            sum+=self.Gr[i]*self.We[i]
            a+=self.We[i]
        
        return sum/a

if __name__ == "__main__":
    Gr = [20,16,18,13]
    We = [3,2,2,1]
    st = Student()
    print(st.Avg())