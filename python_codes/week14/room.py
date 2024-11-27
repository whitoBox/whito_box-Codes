#week 13.room.py

from datetime import datetime as dt

class TimeStamp:
    def __init__(self, intime, outtime = None):
        self.intime = intime
        self.outtime = outtime

    def is_rent(self):
        return not self.outtime

    def diff_seconds(self):
        if self.outtime:
            diff = self.outtime - self.intime
        else:
            diff = dt.now() - self.intime
        return diff


class Room2:
    def __init__(self, number):
        self.number = number
        self.history = []

    def add_timestamp(self,intime,outtime):
        self.history.append(TimeStamp(intime,outtime))
