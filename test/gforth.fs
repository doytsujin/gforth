\ test some gforth extension words

\ Copyright (C) 2003 Free Software Foundation, Inc.

\ This file is part of Gforth.

\ Gforth is free software; you can redistribute it and/or
\ modify it under the terms of the GNU General Public License
\ as published by the Free Software Foundation; either version 2
\ of the License, or (at your option) any later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program; if not, write to the Free Software
\ Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111, USA.

require ./tester.fs
require ./coretest.fs

\ f>str-rdp (then f.rdp and f>buf-rdb should also be ok)

{  12.3456789e 7 3 1 f>str-rdp s"  12.346" str= -> true }
{  12.3456789e 7 4 1 f>str-rdp s" 12.3457" str= -> true }
{ -12.3456789e 7 4 1 f>str-rdp s" -1.23E1" str= -> true }
{      0.0996e 7 3 1 f>str-rdp s"   0.100" str= -> true }
{      0.0996e 7 3 3 f>str-rdp s" 9.96E-2" str= -> true }
{    999.9994e 7 3 1 f>str-rdp s" 999.999" str= -> true }
{    999.9996e 7 3 1 f>str-rdp s" 1.000E3" str= -> true }
{       -1e-20 5 2 1 f>str-rdp s" *******" str= -> true }
