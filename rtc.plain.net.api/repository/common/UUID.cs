using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtc.plain.net.api.repository.common
{
    [Serializable()]
    public sealed class UUID
    {
        private const long serialVersionUID = 1548313159849892768L;
        private static readonly char[] LASTCHAR_DIGITS = "AQgw".ToCharArray();
        private static readonly char[] BASE64_DIGITS = "-0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ_abcdefghijklmnopqrstuvwxyz".ToCharArray();

        private const char UUID_STARTS_WITH = '_';

        private const int UUID_CHAR_LENGTH = 23;

        private const char MAX_UUID_CHAR = '?';

        private static readonly int[] DIGIT_MAP = computeInverseMap(BASE64_DIGITS);
        private static readonly int[] LASTCHAR_DIGIT_MAP = computeInverseMap(LASTCHAR_DIGITS);

        private readonly long msb;

        private readonly long lsb;

        public static UUID generate()
        {
            throw new NotImplementedException();
        }

        public static UUID valueOf(String uuidValue)
        {
            if (uuidValue == null)
            {
                throw new ArgumentException("null UUID");
            }
            char[] trimmedValue = uuidValue.Trim().ToCharArray();
            if (!validateUUID(trimmedValue))
            {
                throw new ArgumentException("invalid UUID");
                /*
                 * TODO : implementar equivalente
                bool shouldLogInvalidUUID = Boolean.Parse(System.getProperty("com.ibm.team.repository.common.UUID.dumpInvalidUUIDsToStderr", "false"));
                if (shouldLogInvalidUUID)
                    System.err.println("com.ibm.team.repository.common.UUID.valueOf(String) invalidUUID: " + uuidValue);
                throw new IllegalArgumentException(String.format("invalid UUID", new Object[0]));
                 */
            }
            return createFrom(trimmedValue);
        }

        private static UUID createFrom(char[] trimmedValue)
        {
            long msb = 0L;

            for (int idx = 1; idx < 11; idx++)
            {
                char nextNested = trimmedValue[idx];

                long nextBitsNested = DIGIT_MAP[nextNested];
                msb <<= 6;
                msb |= nextBitsNested;
            }

            char next = trimmedValue[11];
            long nextBits = DIGIT_MAP[next];
            msb <<= 4;
            msb |= nextBits >> 2;

            long lsb = nextBits & 0x3;

            for (int idx = 12; idx < 22; idx++)
            {
                next = trimmedValue[idx];

                nextBits = DIGIT_MAP[next];
                lsb <<= 6;
                lsb |= nextBits;
            }

            next = trimmedValue[22];
            nextBits = LASTCHAR_DIGIT_MAP[next];
            lsb <<= 2;
            lsb |= nextBits;

            return new UUID(msb, lsb);
        }

        private static bool validateUUID(char[] possibleUUID)
        {
            int len = possibleUUID.Length;

            if (len != 23)
            {
                return false;
            }

            char[] uuidChars = possibleUUID;

            char c = uuidChars[0];

            if (c != '_')
            {
                return false;
            }

            for (int i = 0; i < len; i++)
            {
                c = uuidChars[i];

                if ((c > '?') || (DIGIT_MAP[c] == -1))
                {
                    return false;
                }
            }

            return true;
        }

        private UUID(long msb, long lsb)
        {
            this.msb = msb;
            this.lsb = lsb;
        }

        private static int[] computeInverseMap(char[] digits)
        {
            int[] digitMap = new int['?'];

            for (int i = 0; i < digitMap.Length; i++)
            {
                digitMap[i] = -1;
            }

            for (int i = 0; i < digits.Length; i++)
            {
                char c = digits[i];

                if (c > '?')
                {
                    throw new InvalidOperationException();
                }

                digitMap[c] = i;
            }

            return digitMap;
        }
    }
}
