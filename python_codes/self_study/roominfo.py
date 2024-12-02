from datetime import datetime as dtdt
class room:
    def __init__(self,roomnum,timein,timeout=None):
        self.roomnum = roomnum
        self.timein = timeout
        self.timeout = timeout
    def time_used(self):
        if self.timeout:
            return (self.timeout - self.timein).total_seconds()
        else:
            return (dtdt.now() - self.timein).total_seconds()
