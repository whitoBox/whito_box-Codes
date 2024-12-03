class user1:
    def __init__(self, id, sex, height, weight):
        self.id = id
        self.sex = sex
        self.height = height
        self.weight = weight

    def bmi(self):
        return self.weight / (self.height)**2

    def save(self):
        return f"{self.id}/{self.sex}/{self.height}/{self.weight}"
        

