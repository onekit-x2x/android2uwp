﻿namespace android.os{
    using static android.annotation.NonNull;
    using static android.annotation.Nullable;
    using static android.os.Parcelable.Creator;
    using static android.util.Size;
    using static android.util.SizeF;
    using static android.util.SparseArray;
    using static java.io.Serializable;
    using static java.util.ArrayList;
    public class Bundle : BaseBundle, Cloneable, Parcelable
{

    public static readonly Creator<Bundle> CREATOR = null;
    public static readonly Bundle EMPTY = null;
        public Bundle()
    {
        throw new RuntimeException("Stub!");
    }
    public Bundle(ClassLoader loader)
    {
        throw new RuntimeException("Stub!");
    }
    public Bundle(int capacity)
    {
        throw new RuntimeException("Stub!");
    }
    public Bundle(Bundle b)
    {
        throw new RuntimeException("Stub!");
    }
    public Bundle(PersistableBundle b)
    {
        throw new RuntimeException("Stub!");
    }
    public void setClassLoader(ClassLoader loader)
    {
        throw new RuntimeException("Stub!")
        }
    public ClassLoader getClassLoader()
    {
        throw new RuntimeException("Stub!")
        }
    public Object clone()
    {
        throw new RuntimeException("Stub!")
        }
    public Bundle deepCopy()
    {
        throw new RuntimeException("Stub!")
        }
    public void clear()
    {
        throw new RuntimeException("Stub!")
        }
    public void remove(String key)
    {
        throw new RuntimeException("Stub!")
        }
    public void putAll(Bundle bundle)
    {
        throw new RuntimeException("Stub!")
        }
    public boolean hasFileDescriptors()
    {
        throw new RuntimeException("Stub!")
        }
    public void putByte(String key, byte value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putChar(String key, char value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putShort(String key, short value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putFloat(String key, float value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putCharSequence(String key, CharSequence value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putParcelable(String key, Parcelable value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putSize(String key, Size value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putSizeF(String key, SizeF value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putParcelableArray(String key, Parcelable[] value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putParcelableArrayList(String key, ArrayList<?.null<Parcelable>> value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putSparseParcelableArray(String key, SparseArray<?.null<Parcelable>> value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putIntegerArrayList(String key, ArrayList<Integer> value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putStringArrayList(String key, ArrayList<String> value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putCharSequenceArrayList(String key, ArrayList<CharSequence> value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putSerializable(String key, Serializable value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putByteArray(String key, byte[] value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putShortArray(String key, short[] value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putCharArray(String key, char[] value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putFloatArray(String key, float[] value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putCharSequenceArray(String key, CharSequence[] value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putBundle(String key, Bundle value)
    {
        throw new RuntimeException("Stub!")
        }
    public void putBinder(String key, IBinder value)
    {
        throw new RuntimeException("Stub!")
        }
    public byte getByte(String key)
    {
        throw new RuntimeException("Stub!")
        }
    public Byte getByte(String key, byte defaultValue)
    {
        throw new RuntimeException("Stub!")
        }
    public char getChar(String key)
    {
        throw new RuntimeException("Stub!")
        }
    public char getChar(String key, char defaultValue)
    {
        throw new RuntimeException("Stub!")
        }
    public short getShort(String key)
    {
        throw new RuntimeException("Stub!")
        }
    public short getShort(String key, short defaultValue)
    {
        throw new RuntimeException("Stub!")
        }
    public float getFloat(String key)
    {
        throw new RuntimeException("Stub!")
        }
    public float getFloat(String key, float defaultValue)
    {
        throw new RuntimeException("Stub!")
        }

    public CharSequence getCharSequence(String key)
    {
        throw new RuntimeException("Stub!")
        }
    public CharSequence getCharSequence(String key, CharSequence defaultValue)
    {
        throw new RuntimeException("Stub!")
        }

    public Size getSize(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public SizeF getSizeF(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public Bundle getBundle(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public T getParcelable(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public Parcelable[] getParcelableArray(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public ArrayList<T> getParcelableArrayList(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public SparseArray<T> getSparseParcelableArray(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public Serializable getSerializable(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public ArrayList<Integer> getIntegerArrayList(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public ArrayList<String> getStringArrayList(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public ArrayList<CharSequence> getCharSequenceArrayList(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public byte[] getByteArray(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public short[] getShortArray(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public char[] getCharArray(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public float[] getFloatArray(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public CharSequence[] getCharSequenceArray(String key)
    {
        throw new RuntimeException("Stub!")
        }

    public IBinder getBinder(String key)
    {
        throw new RuntimeException("Stub!")
        }
    public int describeContents()
    {
        throw new RuntimeException("Stub!")
        }
    public void writeToParcel(Parcel parcel, int flags)
    {
        throw new RuntimeException("Stub!")
        }
    public void readFromParcel(Parcel parcel)
    {
        throw new RuntimeException("Stub!")
        }
    public String toString()
    {
        throw new RuntimeException("Stub!")
        }
}
;
}