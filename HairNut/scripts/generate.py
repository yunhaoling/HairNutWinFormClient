import argparse
import os
import time

parser = argparse.ArgumentParser(description='Passing generate parameters')
parser.add_argument('--input', type=str, help='input image file absolute path')
parser.add_argument('--style', type=int, help='hair style integer')

args = parser.parse_args()

def main(input_file, style):
    if not os.path.isfile(args.input):
        return "fail"
    else:
        # TODO: hb logic
        time.sleep(1)  # mock long processing
        return "succeed"

res = main(args.input, args.style)
print(res)
