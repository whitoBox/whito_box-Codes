from datetime import datetime as dtdt
class car1:
    def __init__(self,carnum,intime,outtime=None):
        self.carnum = carnum
        self.intime = intime
        self.outtime = outtime

    def diff_seconds(self):
        if self.outtime == None:
            return (dtdt.now() - self.intime).total_seconds()
        else:
            return (self.outtime - self.intime).total_seconds()
