#!/bin/sh
grep MethodImplOptions.InternalCall * -r | cut -d '/' -f 1 | sort | uniq
