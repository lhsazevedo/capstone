# CS_ARCH_TRICORE, CS_MODE_TRICORE_162, None
0x12, 0x00 = add %d0, %d15, %d0
0x92, 0x00 = add %d0, %d15, 0
0x30, 0x00 = add.a %a0, %a0
0xb0, 0x00 = add.a %a0, 0
0x6b, 0x00, 0x21, 0x00 = add.f %d0, %d0, %d0
0x10, 0x00 = addsc.a %a0, %a0, %d15, 0
0x01, 0x00, 0x00, 0x06 = addsc.a %a0, %a0, %d0, 0
0x01, 0x00, 0x20, 0x06 = addsc.at %a0, %a0, %d0
0x26, 0x00 = and %d0, %d0
0x16, 0x00 = and %d15, 0
0xe0, 0x00 = bisr 0
0x4b, 0x00, 0x10, 0x00 = bmerge %d0, %d0, %d0
0x4b, 0x00, 0x90, 0x00 = bsplit %e0, %d0
0x89, 0x00, 0x80, 0x03 = cachea.i [%a0+]0
0xa9, 0x00, 0x80, 0x03 = cachea.i [%p0+r]
0x89, 0x00, 0x80, 0x07 = cachea.i [+%a0]0
0xa9, 0x00, 0x80, 0x07 = cachea.i [%p0+c]0
0x89, 0x00, 0x80, 0x0b = cachea.i [%a0]0
0x89, 0x00, 0x00, 0x03 = cachea.w [%a0+]0
0xa9, 0x00, 0x00, 0x03 = cachea.w [%p0+r]
0x89, 0x00, 0x00, 0x07 = cachea.w [+%a0]0
0xa9, 0x00, 0x00, 0x07 = cachea.w [%p0+c]0
0x89, 0x00, 0x00, 0x0b = cachea.w [%a0]0
0x89, 0x00, 0x40, 0x03 = cachea.wi [%a0+]0
0xa9, 0x00, 0x40, 0x03 = cachea.wi [%p0+r]
0x89, 0x00, 0x40, 0x07 = cachea.wi [+%a0]0
0xa9, 0x00, 0x40, 0x07 = cachea.wi [%p0+c]0
0x89, 0x00, 0x40, 0x0b = cachea.wi [%a0]0
0x89, 0x00, 0x80, 0x02 = cachei.i [%a0+]0
0x89, 0x00, 0x80, 0x06 = cachei.i [+%a0]0
0x89, 0x00, 0x80, 0x0a = cachei.i [%a0]0
0x89, 0x00, 0xc0, 0x02 = cachei.w [%a0+]0
0x89, 0x00, 0xc0, 0x06 = cachei.w [+%a0]0
0x89, 0x00, 0xc0, 0x0a = cachei.w [%a0]0
0x89, 0x00, 0xc0, 0x03 = cachei.wi [%a0+]0
0x89, 0x00, 0xc0, 0x07 = cachei.wi [+%a0]0
0x89, 0x00, 0xc0, 0x0b = cachei.wi [%a0]0
0x5c, 0x00 = call 0
0x2d, 0x00, 0x00, 0x00 = calli %a0
0x4b, 0x00, 0x00, 0x00 = cmp.f %d0, %d0, %d0
0x49, 0x00, 0xc0, 0x08 = cmpswap.w [%a0]0, %e0
0x69, 0x00, 0xc0, 0x00 = cmpswap.w [%p0+r], %e0
0x69, 0x00, 0xc0, 0x04 = cmpswap.w [%p0+c]0, %e0
0x49, 0x00, 0xc0, 0x00 = cmpswap.w [%a0+]0, %e0
0x49, 0x00, 0xc0, 0x04 = cmpswap.w [+%a0]0, %e0
0x4b, 0x00, 0x60, 0x00 = crc32.b %d0, %d0, %d0
0x4b, 0x00, 0x30, 0x00 = crc32b.w %d0, %d0, %d0
0x4b, 0x00, 0x70, 0x00 = crc32l.w %d0, %d0, %d0
0x6b, 0x00, 0x10, 0x00 = crcn %d0, %d0, %d0, %d0
0x0d, 0x00, 0xc0, 0x03 = disable %d0
0x4b, 0x00, 0x01, 0x02 = div %e0, %d0, %d0
0x4b, 0x00, 0x11, 0x02 = div.u %e0, %d0, %d0
0x4b, 0x00, 0x51, 0x00 = div.f %d0, %d0, %d0
0x6b, 0x00, 0xd0, 0x00 = dvadj %e0, %e0, %d0
0x4b, 0x00, 0xa0, 0x01 = dvinit %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x05 = dvinit.b %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x04 = dvinit.bu %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x03 = dvinit.h %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x02 = dvinit.hu %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x00 = dvinit.u %e0, %d0, %d0
0x6b, 0x00, 0xf0, 0x00 = dvstep %e0, %e0, %d0
0x6b, 0x00, 0xe0, 0x00 = dvstep.u %e0, %e0, %d0
0x61, 0x00, 0x00, 0x00 = fcall 0
0xe1, 0x00, 0x00, 0x00 = fcalla 0
0x2d, 0x00, 0x10, 0x00 = fcalli %a0
0x00, 0x70 = fret
0x0d, 0x00, 0xc0, 0x00 = fret
0x4b, 0x00, 0x01, 0x01 = ftoi %d0, %d0
0x4b, 0x00, 0x11, 0x01 = ftoq31 %d0, %d0, %d0
0x4b, 0x00, 0x21, 0x01 = ftou %d0, %d0
0x4b, 0x00, 0x31, 0x01 = ftoiz %d0, %d0
0x4b, 0x00, 0x81, 0x01 = ftoq31z %d0, %d0, %d0
0x4b, 0x00, 0x71, 0x01 = ftouz %d0, %d0
0x4b, 0x00, 0x51, 0x02 = ftohp %d0, %d0
0x4b, 0x00, 0x41, 0x02 = hptof %d0, %d0
0x4b, 0x00, 0x41, 0x01 = itof %d0, %d0
0x6b, 0x00, 0xa0, 0x00 = ixmax %e0, %e0, %d0
0x6b, 0x00, 0xb0, 0x00 = ixmax.u %e0, %e0, %d0
0x6b, 0x00, 0x80, 0x00 = ixmin %e0, %e0, %d0
0x6b, 0x00, 0x90, 0x00 = ixmin.u %e0, %e0, %d0
0x3c, 0x00 = j 0
0xbe, 0x00 = jeq %d15, %d0, 0
0x9e, 0x00 = jeq %d15, 0, 0
0x3e, 0x00 = jeq %d15, %d0, 0
0x1e, 0x00 = jeq %d15, 0, 0
0xce, 0x00 = jgez %d0, 0
0x4e, 0x00 = jgtz %d0, 0
0xdc, 0x00 = ji %a0
0x2d, 0x00, 0x30, 0x00 = ji %a0
0x8e, 0x00 = jlez %d0, 0
0x2d, 0x00, 0x20, 0x00 = jli %a0
0x0e, 0x00 = jltz %d0, 0
0xfe, 0x00 = jne %d15, %d0, 0
0xde, 0x00 = jne %d15, 0, 0
0x7e, 0x00 = jne %d15, %d0, 0
0x5e, 0x00 = jne %d15, 0, 0
0xee, 0x00 = jnz %d15, 0
0xf6, 0x00 = jnz %d0, 0
0x7c, 0x00 = jnz.a %a0, 0
0xae, 0x00 = jnz.t %d15, 0, 0
0x6e, 0x00 = jz %d15, 0
0x76, 0x00 = jz %d0, 0
0x2e, 0x00 = jz.t %d15, 0, 0
0xd8, 0x00 = ld.a %a15, [%sp]0
0xc8, 0x00 = ld.a %a0, [%a15]0
0xcc, 0x00 = ld.a %a15, [%a0]0
0xc4, 0x00 = ld.a %a0, [%a0+]
0xd4, 0x00 = ld.a %a0, [%a0]
0x79, 0x00, 0x00, 0x00 = ld.b %d0, [%a0]0
0x14, 0x00 = ld.bu %d0, [%a0]
0x0c, 0x00 = ld.bu %d15, [%a0]0
0x08, 0x00 = ld.bu %d0, [%a15]0
0x04, 0x00 = ld.bu %d0, [%a0+]
0x39, 0x00, 0x00, 0x00 = ld.bu %d0, [%a0]0
0x84, 0x00 = ld.h %d0, [%a0+]
0x8c, 0x00 = ld.h %d15, [%a0]0
0x88, 0x00 = ld.h %d0, [%a15]0
0x94, 0x00 = ld.h %d0, [%a0]
0xc9, 0x00, 0x00, 0x00 = ld.h %d0, [%a0]0
0xb9, 0x00, 0x00, 0x00 = ld.hu %d0, [%a0]0
0x58, 0x00 = ld.w %d15, [%sp]0
0x54, 0x00 = ld.w %d0, [%a0]
0x44, 0x00 = ld.w %d0, [%a0+]
0x4c, 0x00 = ld.w %d15, [%a0]0
0x48, 0x00 = ld.w %d0, [%a15]0
0xc5, 0x00, 0x00, 0x04 = lha %a0, 0
0xfd, 0x00, 0x00, 0x80 = loopu 0
0x13, 0x00, 0x60, 0x00 = madd %e0, %e0, %d0, 0
0x03, 0x00, 0x6a, 0x00 = madd %e0, %e0, %d0, %d0
0x6b, 0x00, 0x61, 0x00 = madd.f %d0, %d0, %d0, %d0
0x83, 0x00, 0x60, 0x00 = madd.h %e0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0x64, 0x00 = madd.h %e0, %e0, %d0, %d0lu, 0
0x83, 0x00, 0x68, 0x00 = madd.h %e0, %e0, %d0, %d0ll, 0
0x83, 0x00, 0x6c, 0x00 = madd.h %e0, %e0, %d0, %d0uu, 0
0x43, 0x00, 0x10, 0x00 = madd.q %d0, %d0, %d0u, %d0u, 0
0x43, 0x00, 0x00, 0x00 = madd.q %d0, %d0, %d0, %d0u, 0
0x43, 0x00, 0x04, 0x00 = madd.q %d0, %d0, %d0, %d0l, 0
0x43, 0x00, 0x08, 0x00 = madd.q %d0, %d0, %d0, %d0, 0
0x43, 0x00, 0x14, 0x00 = madd.q %d0, %d0, %d0l, %d0l, 0
0x43, 0x00, 0x60, 0x00 = madd.q %e0, %e0, %d0, %d0u, 0
0x43, 0x00, 0x64, 0x00 = madd.q %e0, %e0, %d0, %d0l, 0
0x43, 0x00, 0x6c, 0x00 = madd.q %e0, %e0, %d0, %d0, 0
0x43, 0x00, 0x70, 0x00 = madd.q %e0, %e0, %d0u, %d0u, 0
0x43, 0x00, 0x74, 0x00 = madd.q %e0, %e0, %d0l, %d0l, 0
0x13, 0x00, 0x40, 0x00 = madd.u %e0, %e0, %d0, 0
0x03, 0x00, 0x68, 0x00 = madd.u %e0, %e0, %d0, %d0
0x83, 0x00, 0x70, 0x00 = maddm.h %e0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0x74, 0x00 = maddm.h %e0, %e0, %d0, %d0lu, 0
0x83, 0x00, 0x78, 0x00 = maddm.h %e0, %e0, %d0, %d0ll, 0
0x83, 0x00, 0x7c, 0x00 = maddm.h %e0, %e0, %d0, %d0uu, 0
0x83, 0x00, 0xf0, 0x00 = maddms.h %e0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0xf4, 0x00 = maddms.h %e0, %e0, %d0, %d0lu, 0
0x83, 0x00, 0xf8, 0x00 = maddms.h %e0, %e0, %d0, %d0ll, 0
0x83, 0x00, 0xfc, 0x00 = maddms.h %e0, %e0, %d0, %d0uu, 0
0x43, 0x00, 0x78, 0x00 = maddr.h %d0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0x30, 0x00 = maddr.h %d0, %d0, %d0, %d0ul, 0
0x83, 0x00, 0x34, 0x00 = maddr.h %d0, %d0, %d0, %d0lu, 0
0x83, 0x00, 0x38, 0x00 = maddr.h %d0, %d0, %d0, %d0ll, 0
0x83, 0x00, 0x3c, 0x00 = maddr.h %d0, %d0, %d0, %d0uu, 0
0x43, 0x00, 0x18, 0x00 = maddr.q %d0, %d0, %d0u, %d0u, 0
0x43, 0x00, 0x1c, 0x00 = maddr.q %d0, %d0, %d0l, %d0l, 0
0x43, 0x00, 0xf8, 0x00 = maddrs.h %d0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0xb0, 0x00 = maddrs.h %d0, %d0, %d0, %d0ul, 0
0x83, 0x00, 0xb4, 0x00 = maddrs.h %d0, %d0, %d0, %d0lu, 0
0x83, 0x00, 0xb8, 0x00 = maddrs.h %d0, %d0, %d0, %d0ll, 0
0x83, 0x00, 0xbc, 0x00 = maddrs.h %d0, %d0, %d0, %d0uu, 0
0x43, 0x00, 0x98, 0x00 = maddrs.q %d0, %d0, %d0u, %d0u, 0
0x43, 0x00, 0x9c, 0x00 = maddrs.q %d0, %d0, %d0l, %d0l, 0
0x13, 0x00, 0xe0, 0x00 = madds %e0, %e0, %d0, 0
0x03, 0x00, 0xea, 0x00 = madds %e0, %e0, %d0, %d0
0x83, 0x00, 0xe0, 0x00 = madds.h %e0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0xe4, 0x00 = madds.h %e0, %e0, %d0, %d0lu, 0
0x83, 0x00, 0xe8, 0x00 = madds.h %e0, %e0, %d0, %d0ll, 0
0x83, 0x00, 0xec, 0x00 = madds.h %e0, %e0, %d0, %d0uu, 0
0x43, 0x00, 0x90, 0x00 = madds.q %d0, %d0, %d0u, %d0u, 0
0x43, 0x00, 0x80, 0x00 = madds.q %d0, %d0, %d0, %d0u, 0
0x43, 0x00, 0x84, 0x00 = madds.q %d0, %d0, %d0, %d0l, 0
0x43, 0x00, 0x88, 0x00 = madds.q %d0, %d0, %d0, %d0, 0
0x43, 0x00, 0x94, 0x00 = madds.q %d0, %d0, %d0l, %d0l, 0
0x43, 0x00, 0xe0, 0x00 = madds.q %e0, %e0, %d0, %d0u, 0
0x43, 0x00, 0xe4, 0x00 = madds.q %e0, %e0, %d0, %d0l, 0
0x43, 0x00, 0xec, 0x00 = madds.q %e0, %e0, %d0, %d0, 0
0x43, 0x00, 0xf0, 0x00 = madds.q %e0, %e0, %d0u, %d0u, 0
0x43, 0x00, 0xf4, 0x00 = madds.q %e0, %e0, %d0l, %d0l, 0
0x13, 0x00, 0xc0, 0x00 = madds.u %e0, %e0, %d0, 0
0x03, 0x00, 0xe8, 0x00 = madds.u %e0, %e0, %d0, %d0
0xc3, 0x00, 0x60, 0x00 = maddsu.h %e0, %e0, %d0, %d0ul, 0
0xc3, 0x00, 0x64, 0x00 = maddsu.h %e0, %e0, %d0, %d0lu, 0
0xc3, 0x00, 0x68, 0x00 = maddsu.h %e0, %e0, %d0, %d0ll, 0
0xc3, 0x00, 0x6c, 0x00 = maddsu.h %e0, %e0, %d0, %d0uu, 0
0xc3, 0x00, 0x70, 0x00 = maddsum.h %e0, %e0, %d0, %d0ul, 0
0xc3, 0x00, 0x74, 0x00 = maddsum.h %e0, %e0, %d0, %d0lu, 0
0xc3, 0x00, 0x78, 0x00 = maddsum.h %e0, %e0, %d0, %d0ll, 0
0xc3, 0x00, 0x7c, 0x00 = maddsum.h %e0, %e0, %d0, %d0uu, 0
0xc3, 0x00, 0xf0, 0x00 = maddsums.h %e0, %e0, %d0, %d0ul, 0
0xc3, 0x00, 0xf4, 0x00 = maddsums.h %e0, %e0, %d0, %d0lu, 0
0xc3, 0x00, 0xf8, 0x00 = maddsums.h %e0, %e0, %d0, %d0ll, 0
0xc3, 0x00, 0xfc, 0x00 = maddsums.h %e0, %e0, %d0, %d0uu, 0
0xc3, 0x00, 0x30, 0x00 = maddsur.h %d0, %d0, %d0, %d0ul, 0
0xc3, 0x00, 0x34, 0x00 = maddsur.h %d0, %d0, %d0, %d0lu, 0
0xc3, 0x00, 0x38, 0x00 = maddsur.h %d0, %d0, %d0, %d0ll, 0
0xc3, 0x00, 0x3c, 0x00 = maddsur.h %d0, %d0, %d0, %d0uu, 0
0xc3, 0x00, 0xb0, 0x00 = maddsurs.h %d0, %d0, %d0, %d0ul, 0
0xc3, 0x00, 0xb4, 0x00 = maddsurs.h %d0, %d0, %d0, %d0lu, 0
0xc3, 0x00, 0xb8, 0x00 = maddsurs.h %d0, %d0, %d0, %d0ll, 0
0xc3, 0x00, 0xbc, 0x00 = maddsurs.h %d0, %d0, %d0, %d0uu, 0
0xc3, 0x00, 0xe0, 0x00 = maddsus.h %e0, %e0, %d0, %d0ul, 0
0xc3, 0x00, 0xe4, 0x00 = maddsus.h %e0, %e0, %d0, %d0lu, 0
0xc3, 0x00, 0xe8, 0x00 = maddsus.h %e0, %e0, %d0, %d0ll, 0
0xc3, 0x00, 0xec, 0x00 = maddsus.h %e0, %e0, %d0, %d0uu, 0
0xd2, 0x00 = mov %e0, 0
0xda, 0x00 = mov %d15, 0
0xfb, 0x00, 0x00, 0x00 = mov %e0, 0
0x0b, 0x00, 0x00, 0x08 = mov %e0, %d0
0x0b, 0x00, 0x10, 0x08 = mov %e0, %d0, %d0
0xa0, 0x00 = mov.a %a0, 0
0x60, 0x00 = mov.a %a0, %d0
0x40, 0x00 = mov.aa %a0, %a0
0x80, 0x00 = mov.d %d0, %a0
0x33, 0x00, 0x60, 0x00 = msub %e0, %e0, %d0, 0
0x23, 0x00, 0x6a, 0x00 = msub %e0, %e0, %d0, %d0
0x6b, 0x00, 0x71, 0x00 = msub.f %d0, %d0, %d0, %d0
0xa3, 0x00, 0x60, 0x00 = msub.h %e0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0x64, 0x00 = msub.h %e0, %e0, %d0, %d0lu, 0
0xa3, 0x00, 0x68, 0x00 = msub.h %e0, %e0, %d0, %d0ll, 0
0xa3, 0x00, 0x6c, 0x00 = msub.h %e0, %e0, %d0, %d0uu, 0
0x63, 0x00, 0x10, 0x00 = msub.q %d0, %d0, %d0u, %d0u, 0
0x63, 0x00, 0x00, 0x00 = msub.q %d0, %d0, %d0, %d0u, 0
0x63, 0x00, 0x04, 0x00 = msub.q %d0, %d0, %d0, %d0l, 0
0x63, 0x00, 0x08, 0x00 = msub.q %d0, %d0, %d0, %d0, 0
0x63, 0x00, 0x14, 0x00 = msub.q %d0, %d0, %d0l, %d0l, 0
0x63, 0x00, 0x60, 0x00 = msub.q %e0, %e0, %d0, %d0u, 0
0x63, 0x00, 0x64, 0x00 = msub.q %e0, %e0, %d0, %d0l, 0
0x63, 0x00, 0x6c, 0x00 = msub.q %e0, %e0, %d0, %d0, 0
0x63, 0x00, 0x70, 0x00 = msub.q %e0, %e0, %d0u, %d0u, 0
0x63, 0x00, 0x74, 0x00 = msub.q %e0, %e0, %d0l, %d0l, 0
0x33, 0x00, 0x40, 0x00 = msub.u %e0, %e0, %d0, 0
0x23, 0x00, 0x68, 0x00 = msub.u %e0, %e0, %d0, %d0
0xe3, 0x00, 0x60, 0x00 = msubad.h %e0, %e0, %d0, %d0ul, 0
0xe3, 0x00, 0x64, 0x00 = msubad.h %e0, %e0, %d0, %d0lu, 0
0xe3, 0x00, 0x68, 0x00 = msubad.h %e0, %e0, %d0, %d0ll, 0
0xe3, 0x00, 0x6c, 0x00 = msubad.h %e0, %e0, %d0, %d0uu, 0
0xe3, 0x00, 0x70, 0x00 = msubadm.h %e0, %e0, %d0, %d0ul, 0
0xe3, 0x00, 0x74, 0x00 = msubadm.h %e0, %e0, %d0, %d0lu, 0
0xe3, 0x00, 0x78, 0x00 = msubadm.h %e0, %e0, %d0, %d0ll, 0
0xe3, 0x00, 0x7c, 0x00 = msubadm.h %e0, %e0, %d0, %d0uu, 0
0xe3, 0x00, 0xf0, 0x00 = msubadms.h %e0, %e0, %d0, %d0ul, 0
0xe3, 0x00, 0xf4, 0x00 = msubadms.h %e0, %e0, %d0, %d0lu, 0
0xe3, 0x00, 0xf8, 0x00 = msubadms.h %e0, %e0, %d0, %d0ll, 0
0xe3, 0x00, 0xfc, 0x00 = msubadms.h %e0, %e0, %d0, %d0uu, 0
0xe3, 0x00, 0x30, 0x00 = msubadr.h %d0, %d0, %d0, %d0ul, 0
0xe3, 0x00, 0x34, 0x00 = msubadr.h %d0, %d0, %d0, %d0lu, 0
0xe3, 0x00, 0x38, 0x00 = msubadr.h %d0, %d0, %d0, %d0ll, 0
0xe3, 0x00, 0x3c, 0x00 = msubadr.h %d0, %d0, %d0, %d0uu, 0
0xe3, 0x00, 0xb0, 0x00 = msubadrs.h %d0, %d0, %d0, %d0ul, 0
0xe3, 0x00, 0xb4, 0x00 = msubadrs.h %d0, %d0, %d0, %d0lu, 0
0xe3, 0x00, 0xb8, 0x00 = msubadrs.h %d0, %d0, %d0, %d0ll, 0
0xe3, 0x00, 0xbc, 0x00 = msubadrs.h %d0, %d0, %d0, %d0uu, 0
0xe3, 0x00, 0xe0, 0x00 = msubads.h %e0, %e0, %d0, %d0ul, 0
0xe3, 0x00, 0xe4, 0x00 = msubads.h %e0, %e0, %d0, %d0lu, 0
0xe3, 0x00, 0xe8, 0x00 = msubads.h %e0, %e0, %d0, %d0ll, 0
0xe3, 0x00, 0xec, 0x00 = msubads.h %e0, %e0, %d0, %d0uu, 0
0xa3, 0x00, 0x70, 0x00 = msubm.h %e0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0x74, 0x00 = msubm.h %e0, %e0, %d0, %d0lu, 0
0xa3, 0x00, 0x78, 0x00 = msubm.h %e0, %e0, %d0, %d0ll, 0
0xa3, 0x00, 0x7c, 0x00 = msubm.h %e0, %e0, %d0, %d0uu, 0
0xa3, 0x00, 0xf0, 0x00 = msubms.h %e0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0xf4, 0x00 = msubms.h %e0, %e0, %d0, %d0lu, 0
0xa3, 0x00, 0xf8, 0x00 = msubms.h %e0, %e0, %d0, %d0ll, 0
0xa3, 0x00, 0xfc, 0x00 = msubms.h %e0, %e0, %d0, %d0uu, 0
0x63, 0x00, 0x78, 0x00 = msubr.h %d0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0x30, 0x00 = msubr.h %d0, %d0, %d0, %d0ul, 0
0xa3, 0x00, 0x34, 0x00 = msubr.h %d0, %d0, %d0, %d0lu, 0
0xa3, 0x00, 0x38, 0x00 = msubr.h %d0, %d0, %d0, %d0ll, 0
0xa3, 0x00, 0x3c, 0x00 = msubr.h %d0, %d0, %d0, %d0uu, 0
0x63, 0x00, 0x18, 0x00 = msubr.q %d0, %d0, %d0u, %d0u, 0
0x63, 0x00, 0x1c, 0x00 = msubr.q %d0, %d0, %d0l, %d0l, 0
0x63, 0x00, 0xf8, 0x00 = msubrs.h %d0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0xb0, 0x00 = msubrs.h %d0, %d0, %d0, %d0ul, 0
0xa3, 0x00, 0xb4, 0x00 = msubrs.h %d0, %d0, %d0, %d0lu, 0
0xa3, 0x00, 0xb8, 0x00 = msubrs.h %d0, %d0, %d0, %d0ll, 0
0xa3, 0x00, 0xbc, 0x00 = msubrs.h %d0, %d0, %d0, %d0uu, 0
0x63, 0x00, 0x98, 0x00 = msubrs.q %d0, %d0, %d0u, %d0u, 0
0x63, 0x00, 0x9c, 0x00 = msubrs.q %d0, %d0, %d0l, %d0l, 0
0x33, 0x00, 0xe0, 0x00 = msubs %e0, %e0, %d0, 0
0x23, 0x00, 0xea, 0x00 = msubs %e0, %e0, %d0, %d0
0xa3, 0x00, 0xe0, 0x00 = msubs.h %e0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0xe4, 0x00 = msubs.h %e0, %e0, %d0, %d0lu, 0
0xa3, 0x00, 0xe8, 0x00 = msubs.h %e0, %e0, %d0, %d0ll, 0
0xa3, 0x00, 0xec, 0x00 = msubs.h %e0, %e0, %d0, %d0uu, 0
0x63, 0x00, 0x90, 0x00 = msubs.q %d0, %d0, %d0u, %d0u, 0
0x63, 0x00, 0x80, 0x00 = msubs.q %d0, %d0, %d0, %d0u, 0
0x63, 0x00, 0x84, 0x00 = msubs.q %d0, %d0, %d0, %d0l, 0
0x63, 0x00, 0x88, 0x00 = msubs.q %d0, %d0, %d0, %d0, 0
0x63, 0x00, 0x94, 0x00 = msubs.q %d0, %d0, %d0l, %d0l, 0
0x63, 0x00, 0xe0, 0x00 = msubs.q %e0, %e0, %d0, %d0u, 0
0x63, 0x00, 0xe4, 0x00 = msubs.q %e0, %e0, %d0, %d0l, 0
0x63, 0x00, 0xec, 0x00 = msubs.q %e0, %e0, %d0, %d0, 0
0x63, 0x00, 0xf0, 0x00 = msubs.q %e0, %e0, %d0u, %d0u, 0
0x63, 0x00, 0xf4, 0x00 = msubs.q %e0, %e0, %d0l, %d0l, 0
0x33, 0x00, 0xc0, 0x00 = msubs.u %e0, %e0, %d0, 0
0x23, 0x00, 0xe8, 0x00 = msubs.u %e0, %e0, %d0, %d0
0x73, 0x00, 0x0a, 0x00 = mul %d0, %d0, %d0
0x53, 0x00, 0x60, 0x00 = mul %e0, %d0, 0
0x73, 0x00, 0x6a, 0x00 = mul %e0, %d0, %d0
0x4b, 0x00, 0x41, 0x00 = mul.f %d0, %d0, %d0
0xb3, 0x00, 0x60, 0x00 = mul.h %e0, %d0, %d0ul, 0
0xb3, 0x00, 0x64, 0x00 = mul.h %e0, %d0, %d0lu, 0
0xb3, 0x00, 0x68, 0x00 = mul.h %e0, %d0, %d0ll, 0
0xb3, 0x00, 0x6c, 0x00 = mul.h %e0, %d0, %d0uu, 0
0x93, 0x00, 0x00, 0x00 = mul.q %d0, %d0, %d0u, 0
0x93, 0x00, 0x04, 0x00 = mul.q %d0, %d0, %d0l, 0
0x93, 0x00, 0x08, 0x00 = mul.q %d0, %d0, %d0, 0
0x93, 0x00, 0x10, 0x00 = mul.q %d0, %d0u, %d0u, 0
0x93, 0x00, 0x14, 0x00 = mul.q %d0, %d0l, %d0l, 0
0x93, 0x00, 0x60, 0x00 = mul.q %e0, %d0, %d0u, 0
0x93, 0x00, 0x64, 0x00 = mul.q %e0, %d0, %d0l, 0
0x93, 0x00, 0x6c, 0x00 = mul.q %e0, %d0, %d0, 0
0x53, 0x00, 0x40, 0x00 = mul.u %e0, %d0, 0
0x73, 0x00, 0x68, 0x00 = mul.u %e0, %d0, %d0
0xb3, 0x00, 0x70, 0x00 = mulm.h %e0, %d0, %d0ul, 0
0xb3, 0x00, 0x74, 0x00 = mulm.h %e0, %d0, %d0lu, 0
0xb3, 0x00, 0x78, 0x00 = mulm.h %e0, %d0, %d0ll, 0
0xb3, 0x00, 0x7c, 0x00 = mulm.h %e0, %d0, %d0uu, 0
0xb3, 0x00, 0xf0, 0x00 = mulms.h %e0, %d0, %d0ul, 0
0xb3, 0x00, 0xf4, 0x00 = mulms.h %e0, %d0, %d0lu, 0
0xb3, 0x00, 0xf8, 0x00 = mulms.h %e0, %d0, %d0ll, 0
0xb3, 0x00, 0xfc, 0x00 = mulms.h %e0, %d0, %d0uu, 0
0xb3, 0x00, 0x30, 0x00 = mulr.h %d0, %d0, %d0ul, 0
0xb3, 0x00, 0x34, 0x00 = mulr.h %d0, %d0, %d0lu, 0
0xb3, 0x00, 0x38, 0x00 = mulr.h %d0, %d0, %d0ll, 0
0xb3, 0x00, 0x3c, 0x00 = mulr.h %d0, %d0, %d0uu, 0
0x93, 0x00, 0x18, 0x00 = mulr.q %d0, %d0u, %d0u, 0
0x93, 0x00, 0x1c, 0x00 = mulr.q %d0, %d0l, %d0l, 0
0x73, 0x00, 0x8a, 0x00 = muls %d0, %d0, %d0
0x73, 0x00, 0x88, 0x00 = muls.u %d0, %d0, %d0
0x46, 0x00 = nor %d0
0xa6, 0x00 = or %d0, %d0
0x96, 0x00 = or %d15, 0
0x4b, 0x00, 0x20, 0x00 = parity %d0, %d0
0x4b, 0x00, 0x20, 0x02 = popcnt.w %d0, %d0
0x4b, 0x00, 0x51, 0x01 = q31tof %d0, %d0, %d0
0x4b, 0x00, 0x91, 0x01 = qseed.f %d0, %d0
0x0d, 0x00, 0x80, 0x03 = restore %d0
0x0d, 0x00, 0x80, 0x01 = ret
0x0d, 0x00, 0xc0, 0x01 = rfe
0x0d, 0x00, 0x40, 0x01 = rfm
0x32, 0x50 = rsub %d0
0x32, 0x00 = sat.b %d0
0x32, 0x10 = sat.bu %d0
0x32, 0x20 = sat.h %d0
0x32, 0x30 = sat.hu %d0
0x06, 0x00 = sh %d0, 0
0x86, 0x00 = sha %d0, 0
0x8f, 0x00, 0xe0, 0x00 = shuffle %d0, %d0, 0
0xf8, 0x00 = st.a [%sp]0, %a15
0xec, 0x00 = st.a [%a0]0, %a15
0xe8, 0x00 = st.a [%a15]0, %a0
0xe4, 0x00 = st.a [%a0+], %a0
0xf4, 0x00 = st.a [%a0], %a0
0xb5, 0x00, 0x00, 0x00 = st.a [%a0]0, %a0
0x34, 0x00 = st.b [%a0], %d0
0x28, 0x00 = st.b [%a15]0, %d0
0x2c, 0x00 = st.b [%a0]0, %d15
0x24, 0x00 = st.b [%a0+], %d0
0xe9, 0x00, 0x00, 0x00 = st.b [%a0]0, %d0
0xa4, 0x00 = st.h [%a0+], %d0
0xa8, 0x00 = st.h [%a15]0, %d0
0xac, 0x00 = st.h [%a0]0, %d15
0xb4, 0x00 = st.h [%a0], %d0
0xf9, 0x00, 0x00, 0x00 = st.h [%a0]0, %d0
0x78, 0x00 = st.w [%sp]0, %d15
0x74, 0x00 = st.w [%a0], %d0
0x64, 0x00 = st.w [%a0+], %d0
0x68, 0x00 = st.w [%a15]0, %d0
0x6c, 0x00 = st.w [%a0]0, %d15
0x52, 0x00 = sub %d0, %d15, %d0
0x20, 0x00 = sub.a %sp, 0
0x6b, 0x00, 0x31, 0x00 = sub.f %d0, %d0, %d0
0x69, 0x00, 0x00, 0x08 = swap.w [%p0+i], %d0
0x49, 0x00, 0x80, 0x00 = swapmsk.w [%a0+]0, %e0
0x69, 0x00, 0x80, 0x00 = swapmsk.w [%p0+r], %e0
0x49, 0x00, 0x80, 0x04 = swapmsk.w [+%a0]0, %e0
0x69, 0x00, 0x80, 0x04 = swapmsk.w [%p0+c]0, %e0
0x49, 0x00, 0x80, 0x08 = swapmsk.w [%a0]0, %e0
0x69, 0x00, 0x80, 0x08 = swapmsk.w [%p0+i], %e0
0x75, 0x00, 0x00, 0x00 = tlbdemap %d0
0x75, 0x00, 0x40, 0x00 = tlbflush.a
0x75, 0x00, 0x50, 0x00 = tlbflush.b
0x75, 0x00, 0x00, 0x04 = tlbmap %e0
0x75, 0x00, 0x80, 0x00 = tlbprobe.a %d0
0x75, 0x00, 0x90, 0x00 = tlbprobe.i %d0
0x4b, 0x00, 0x80, 0x00 = unpack %e0, %d0
0x4b, 0x00, 0xc1, 0x00 = updfl %d0
0x4b, 0x00, 0x61, 0x01 = utof %d0, %d0
0x0d, 0x00, 0x80, 0x05 = wait
0xc6, 0x00 = xor %d0, %d0
